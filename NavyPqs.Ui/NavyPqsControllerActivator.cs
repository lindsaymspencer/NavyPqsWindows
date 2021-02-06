using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using NavyPqs.Data;
using NavyPqs.Domain.Models;
using NavyPqs.Logger;
using NavyPqs.Ui.Controllers;

namespace NavyPqs.Ui
{
    public class NavyPqsControllerActivator : IControllerActivator
    {
        public object Create(ControllerContext context)
        {
            Type type = context.ActionDescriptor.ControllerTypeInfo.AsType();

            if (type == typeof(HomeController))
            {
                return CreateHomeController();
            }
            else
            {
                throw new Exception("Unknown controller " + type.Name);
            }
        }

        public void Release(ControllerContext context, object controller)
        {
            var disposables = (List<IDisposable>) context.HttpContext.Items["Disposables"];

            if (disposables == null) return;
            disposables.Reverse();

            foreach (var disposable in disposables)
            {
                disposable.Dispose();
            }
        }

        private HomeController CreateHomeController()
        {
            return new HomeController(
                new LocalFileLogger(), 
                new OfficerService(
                    new OfficerRepository()));
        }
    }
}
