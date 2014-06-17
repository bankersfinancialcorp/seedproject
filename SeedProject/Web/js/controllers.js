'use strict';

/* Controllers */

angular.module('myApp.controllers', [])
  .controller('ViewCtrl', ['$scope', '$http', function ($scope, $http) {
      $http.get('/api/Message').success(function (data) {
          $scope.messages = data;
      });
  }])
  .controller('CreateCtrl', ['$scope', '$http', function ($scope, $http) {
      $scope.submit = function () {

          $http.post('/api/Message', {text:$scope.message}).success(function (data) {
              $scope.messages.add(data);
          });
          
      };
  }]);

