// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.
const INFO = 1;
const SUCCESS = 2;
const WARNING = 3;
const ERROR = 4;



function showNotif(typeNotif, message, innerException) {

    $('#btnCopy').html('Copier le texte');
    $('#alertTop').removeClass('alert-primary');
    $('#alertTop').removeClass('alert-success');
    $('#alertTop').removeClass('alert-danger');
    $('#alertTop').removeClass('alert-warning');

    switch (typeNotif) {
        case INFO:
            $('#alertTop').addClass('alert-primary');
            break;
        case SUCCESS:
            $('#alertTop').addClass('alert-success');
            break;
        case WARNING:
            $('#alertTop').addClass('alert-warning');
            break;
        case ERROR:
            $('#alertTop').addClass('alert-danger');
            break;
        default:
    }

    let exception = "";
    if (innerException) {
        exception = "</br> Exception : " + innerException;
    }
    $('#textAlert').html(message + exception);
    //On a besoin de ce champ pour effectuer le "copier" dans le presse-papier
    $('#hiddenAlertText').val(message + exception);
    $('#alertTop').show();
    setTimeout('$("#alertTop").hide("slow")', 10000);
}


function showNotifMessageObject(data) {
    showNotif(data.severity, data.message, data.innerException);
}

function copyText(element) {
    var $temp = $("<input>");
    $("body").append($temp);
    $temp.val($(element).text()).select();
    document.execCommand("copy");
    $temp.remove();
    $('#btnCopy').html('Texte copier')
}

function clearForm(formId) {
    $(':input', formId)
        .not(':button, :submit, :reset, :hidden')
        .val('')
        .prop('checked', false)
        .prop('selected', false);
}


//Transformer un formulaire en objet VM
function objectifyForm(formId) {
    //serialize data function
    var returnArray = {};
    let formArray = $('#' + formId).serializeArray();
    let duplicateArray = [];
    for (var i = 0; i < formArray.length; i++) {
        if (duplicateArray.indexOf(formArray[i]['name']) === -1) {
            duplicateArray.push(formArray[i]['name']);
            returnArray[formArray[i]['name']] = formArray[i]['value'];
        }
    }
    return returnArray;
}

//Transformer une datatable en objet VM
function objectifyGrid(gridId) {
    var returnArray = [];

    let formArray = $('#' + gridId).DataTable().rows().data();
    for (var i = 0; i < formArray.length; i++) {
        let firstItem = formArray[i];
        let itemToAdd = {};
        for (var j in firstItem) {
            //Pour mettre la première lettre en majuscule
            let varName = j.charAt(0).toUpperCase() + j.substr(1);
            let value;
            value = (jQuery.type(firstItem[j]) === "object") ? objectifyItem(firstItem[j])
                :(jQuery.type(firstItem[j]) === "boolean") ? firstItem[j].toString().charAt(0).toUpperCase() + firstItem[j].toString().substr(1)
                                                          : firstItem[j];
            itemToAdd[varName] = value;
        }
        returnArray.push(itemToAdd);
    }
    return returnArray;
}

function objectifyItem(item) {

    let newItem = {};
    for (const prop in item) {
        let varName = prop.charAt(0).toUpperCase() + prop.substr(1);
        newItem[varName] = (jQuery.type(item[prop]) === "object") ? objectifyItem(item[prop]) : item[prop];
    }
    return newItem;
}