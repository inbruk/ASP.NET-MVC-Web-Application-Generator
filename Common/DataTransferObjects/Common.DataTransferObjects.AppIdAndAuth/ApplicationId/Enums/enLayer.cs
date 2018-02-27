namespace Common.DataTransferObjects.AppIdAndAuth.ApplicationId 
{ 
    using System;

    public enum enLayer
    { 
        AnyLayer=0, 
        DataLayer=1, 
        DataAccessLayer=2, 
        DataTransferObjects=3, 
        BusinessLayer=4, 
        WebServiceLayer=5, 
        WebServiceClient=6, 
        WebUserInterface_Model=7, 
        WebUserInterface_Controller=8, 
        WebUserInterface_View=9, 
    } 
} 
