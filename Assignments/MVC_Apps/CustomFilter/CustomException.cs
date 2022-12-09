using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace MVC_Apps.CustomFilter
{
    public class CustomException : IExceptionFilter
    {
        private IModelMetadataProvider modelMetadataProvider;
        public CustomException(IModelMetadataProvider modelMetadata)
        {
            this.modelMetadataProvider = modelMetadata;
        }
        public void OnException(ExceptionContext context)
        {
            context.ExceptionHandled = true;
            string errorMessage= context.Exception.Message;
            ViewResult result= new ViewResult();
            result.ViewName = "DbError";
            ViewDataDictionary viewData = new ViewDataDictionary(modelMetadataProvider, context.ModelState);
            // 3.b. Set Key:Value for ViewData
            viewData["Controller"] = context.RouteData.Values["controller"].ToString();
            viewData["Action"] = context.RouteData.Values["action"].ToString();
            viewData["ErrorMessage"] = errorMessage;

            // 3.c. Set the viewData to the ViewData property of the ViewResult
            result.ViewData = viewData;

            // 4. Set the REsult as ViewREsult
            context.Result = result;
        }
    }
}
