(function () {
    'use strict';
    var clientServices = angular.module('clientServices', ['ngResource']);

    clientServices.factory('Clients', ['$resource',
      function ($resource) {
          return $resource('api/client/AllClients', {}, {
              query: { method: 'GET', params: {}, isArray: true }
          });
      }]);

})();