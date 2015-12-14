(function () {
    'use strict';
    angular
    .module('reportApp')
    .controller('reportController', reportController)

    reportController.$inject = ['$scope'];

    function reportController($scope) {
        $scope.Title = 'DevXtreme Reports';
    }

})();