app.controller("myCtrl", function ($scope, carService) {
    
    $scope.List = function() 
    {
      carService.GetCarList().then(function(result)
      {
          $scope.carSets = result;
      });
    }
    $scope.List();
});