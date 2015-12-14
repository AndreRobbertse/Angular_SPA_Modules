(function () {

    'use strict';

    var app = angular.module('reportApp', ['ngRoute','ui.router', 'ui.bootstrap', 'ui.grid', 'clientServices']);

    //app.config(function ($routeProvider) {
    //    $routeProvider
    //        .when("/home", {
    //            templateUrl: "/client/home/home.html",
    //            controller: "homeController"
    //        })
    //    .when("/report", {
    //        templateUrl: "/client/report/report.html",
    //        controller: "reportController"
    //    })
    //    .otherwise({ redirectTo: "/home" })
    //});

})();
