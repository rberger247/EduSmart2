var myApp = angular.module("myApp", ['ui.router']);

myApp.controller("LoginController", LoginController);


 myApp.config(function ($stateProvider, $urlRouterProvider, $locationProvider) {
    
     $stateProvider
         .state('login', {
             url: '/Login',
             templateUrl: '/home/Login',
             controller: LoginController,
             controllerAs: 'controller'
         })
      
            .state('Index', {
                url: '/',
                templateUrl: '/home/index'
            })
     // Handle request for non-existent route
  
     $urlRouterProvider.otherwise('/login');
     $locationProvider.html5Mode({
         enabled: true,
         requireBase: false
     });


 });