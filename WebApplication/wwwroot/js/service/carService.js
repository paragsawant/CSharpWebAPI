app.service('carService',['$http','$rootScope', function($http,$rootScope)
{
    this.GetCarList = function()
    {
        return $http.get("api/cars").then(function(response){
        return response.data;
        });
    }
}]);