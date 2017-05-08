app.service('carService',['$http','$rootScope', function($http,$rootScope)
{
    this.GetCarList = function()
    {
        return $http.get("api/cars").then(function(response){
        return response.data;
        });
    }
    
    this.AddNewCar = function(carSet)
    {
        return $http.post("api/cars",carSet).success(function(result){
        return result.data;
    })
    .error(function(carSet, status, headers, config){

    });
    }
}]);