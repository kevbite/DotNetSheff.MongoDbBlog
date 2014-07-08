using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Bson;

namespace DotNetSheff.MongoDbBlog.ModelBinders
{
    public class ObjectIdModelBinder : DefaultModelBinder
    {
        public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            string value = controllerContext.RouteData.Values[bindingContext.ModelName] as string;
            if (String.IsNullOrEmpty(value))
            {
                return ObjectId.Empty;
            }
            return new ObjectId(value);
        }
    }
}