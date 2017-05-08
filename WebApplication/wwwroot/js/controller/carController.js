app.controller("myCtrl", function ($scope,$location, carService) {
    
    $scope.carSet = {};
    $scope.IsVisible = false;
    $scope.List = function() 
    {
      carService.GetCarList().then(function(result)
      {
          $scope.carSets = result;
      });
    }
    $scope.List();

    $scope.AddNewCar = function(carSet)
    {
        carService.AddNewCar(carSet).then(function(result)
        {
            if(result.data==0)
            {
                $scope.IsVisible = true;
            }
            else
            {
                $scope.List();  
                $scope.redirectHomePage = $location.path("/list");
            }
        })
    }
});