using Commun.Constantes;
using Commun.Enums;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DTOs
{
    public static class ListMessageExtension
    {
        //    public static MessageDTO GetCreationMessageOk()
        //    {
        //        return new MessageDTO()
        //        {
        //            Message = MessageConst.CREATION_OK,
        //            Severity = SeverityEnum.SUCCESS,
        //        };
        //    }

        //    public static MessageDTO GetDeleteMessageOk()
        //    {
        //        return new MessageDTO()
        //        {
        //            Message = MessageConst.DELETE_OK,
        //            Severity = SeverityEnum.SUCCESS,
        //        };
        //    }

        //    public static MessageDTO GetUpdateMessageOk()
        //    {
        //        return new MessageDTO()
        //        {
        //            Message = MessageConst.UPDATE_OK,
        //            Severity = SeverityEnum.SUCCESS,
        //        };
        //    }

        //    public static MessageDTO GetUpdateMessageKo()
        //    {
        //        return new MessageDTO()
        //        {
        //            Message = MessageConst.UPDATE_KO,
        //            Severity = SeverityEnum.ERROR,
        //        };
        //    }
        //    public static MessageDTO GetErrorMessage(Exception e)
        //    {
        //        return new MessageDTO()
        //        {
        //            Message = e.Message,
        //            Severity = SeverityEnum.ERROR,
        //            InnerException = e.InnerException?.Message,
        //        };
        //    }

        //    public static MessageDTO ArgumentNullMessage(string argumentName,
        //                                                [CallerMemberName] string functionName = "",
        //                                                [CallerFilePath] string sourceFilePath = "",
        //                                                [CallerLineNumber] int sourceLineNumber = 0)
        //    {
        //        MessageDTO message = new MessageDTO();
        //        string msg = string.Format(MessageConst.INVALID_ARGUMENT_EXCEPTION, argumentName);
        //        message.Message = MessageConst.GENERIC_ERROR_MESSAGE;
        //        message.InnerException = $"{msg} dans la fonction {functionName} du fichier {sourceFilePath} à la ligne {sourceLineNumber}";
        //        message.Severity = SeverityEnum.ERROR;
        //        return message;
        //    }
    }
}
