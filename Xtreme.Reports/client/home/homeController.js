(function () {
    'use strict';
    angular
    .module('reportApp')
    .controller('homeController', homeController)

    homeController.$inject = ['$scope', 'Clients'];

    function homeController($scope, Clients) {
        $scope.Title = 'Home';
        $scope.clients = Clients.query();
        $scope.gridOptions = { data: $scope.clients };
    }

})();