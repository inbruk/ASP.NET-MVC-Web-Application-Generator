namespace Common.DataTransferObjects.AppIdAndAuth.ApplicationId 
{ 
    using System;

    public enum enMethod
    { 
        AnyMethod=0, 
        ReadWithFilters=1, 
        CreateOne=2, 
        ReadOne=3, 
        UpdateOne=4, 
        DeleteOne=5, 
        CreateMultiple=6, 
        ReadMultiple=7, 
        UpdateMultiple=8, 
        DeleteMultiple=9, 
        CreateLink=10, 
        ReadLink=11, 
        UpdateLink=12, 
        DeleteLink=13, 
    } 
} 
