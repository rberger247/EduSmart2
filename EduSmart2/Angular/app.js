
var myApp = angular.module("myApp", ['ngRoute']);

//App.controller("loginController", LoginController);

myApp.config(function ($stateProvider, $routeProvider, $urlRouterProvider, $locationProvider) {

 //   $stateProvider
 //       .state('home', {
 //           url: '/home',
 //           templateUrl: '/home/index',
 //           controller: LoginController,
 //           controllerAs: 'controller'
 //       })
 //   $stateProvider
 //    .state('login', {
 //        url: '/login',
 //        templateUrl: '/home/login',
 //        controller: LoginController,
 //        controllerAs: 'controller'
 //    })
 //   $urlRouterProvider.otherwise('/');

 //   // Enable HTML5 navigation
 //   $locationProvider.hashPrefix('!').html5Mode(true);
 //$locationProvider.html5Mode(true);
});
   