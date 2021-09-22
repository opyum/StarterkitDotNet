using System;
using System.Collections.Generic;
using System.Text;

namespace Commun.Constantes
{
    public static class ApiRouteConst
    {
        public const string GENERIC_GET_ALL = "GetAll";
        public const string GENERIC_GET_ALL_ACTIVE = "GetAllActive";
        public const string GENERIC_GET_BY_ID = "GetById";
        public const string GENERIC_CREATE = "Create";
        public const string GENERIC_UPDATE = "Update";
        public const string GENERIC_DELETE = "Delete";

        public const string APPLICATION_CONTROLLER = "Application";
        public const string CLIENT_CONTROLLER = "Client";
        public const string INFRASTRUCTURE_CONTROLLER = "Infrastructure";
        public const string ENVIRONNEMENT_CONTROLLER = "Environnement";
        public const string VERSION_CONTROLLER = "Version";

        public const string ROLE_CONTROLLER = "Role";
        public const string ROLE_CREATE_ROLE_RIGHT = "CreateRoleRight";
        public const string ROLE_UPDATE_ROLE_RIGHT = "UpdateRoleRight";

        public const string CONFIG_FILES_CONTROLLER = "ConfigFiles";
        public const string CONFIG_FILES_GET_BY_ID_APPLI = "GetByIdAppli";

        public const string ROLE_RIGHT_CONTROLLER = "RoleRight";
        public const string ROLE_RIGHT_GET_ALL_RIGHTS_BY_USER_MAIL = "GetAllRightsByUserMail";
        public const string ROLE_RIGHT_GET_ALL_TEMPLATE = "GetAllTemplate";
        public const string ROLE_RIGHT_GET_RIGHTS_BY_ID_ROLE = "GetRightsByIdRole";

        public const string AUTHENTICATION_CONTROLLER = "Authentication";
        public const string AUTHENTICATE = "Authenticate";

        public const string LOGIN_CONTROLLER = "User";
        public const string USER_CONTROLLER_GET_ALL_WITH_ROLE = "GetAllWithRole";

        public const string VARIABLE_CONTROLLER = "Variable";


    }
}           
