
myApp.controller('CreateSpellController', ['$scope', '$log', '$http', '$location', function ($scope, $log, $http, $location) {

    $scope.spell = {
        Range: 0
    };

    $scope.addSpellLevel = function () {

        if ($scope.spell.SpellLevels === undefined) {
            $scope.spell.SpellLevels = [];
        }

        var spellLevel = {
            SpellClass: $scope.spellClass,
            Level: $scope.spellLevel
        };

        $scope.spell.SpellLevels.push(spellLevel);

        $scope.spellClass = undefined;
        $scope.spellLevel = undefined;

    };

    $scope.remove = function (array, index) {
        array.splice(index, 1);
    };

    $scope.addSpell = function () {

        // Show the Loading modal

        var config = {
            method: 'POST',
            url: 'Create',
            data: $scope.spell
        };

        $http(config).
          success(function (data) {

              // Move the user back to the homepage
              window.location = '/';

          }).
          error(function (data, status, headers, config) {

              // Report to the user that an error has occured
              $scope.saveError = true;

              // Write the error information to the log
              $log.error(data);
              $log.error(status);
              $log.error(headers);
              $log.error(config);

          });

    };

    $scope.saveError = false;

}]);