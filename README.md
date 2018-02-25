# EduSmart2



### Technologies and Frameworks

* Visual studio 2015
* asp.Net v. 4.7 web Api Mvc

### Deploying to azure
[Follow this step by step](https://docs.microsoft.com/en-us/azure/app-service/app-service-deploy-local-git)


### Adding angularJs to Mvc Project
```
* add angular to project by installing in project from nuget package manager

```

![nugetangular](https://user-images.githubusercontent.com/29547972/36638073-549ca95e-19b8-11e8-86f5-abc246227df6.png)
 ```
* In Bundle.config file add reference to angular                      
        bundles.Add(new ScriptBundle("~/bundles/Angular").Include(
                        "~/Scripts/angular.min.js"));
* Create folder for all declarations of controllers and services called NgApp
* Add a Javascript file to folder call it app.js
* Declare the angular module in the file:
 
    var myApp = angular.module("myApp", []);
  
 * Bundle it in the bundle.config file:

      bundles.Add(new ScriptBundle("~/bundles/NgApp").Include(
                      "~/NgApp/app.js"));
                      
  * Load the scripts in a shared view such as _layout.cshtml
       @Scripts.Render("~/bundles/Angular")
       @Scripts.Render("~/bundles/NgApp")

* In _layout.cshtml declare your app as an angular app 

  <html ng-app="myApp">

```

