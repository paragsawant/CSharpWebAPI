app.config(function($stateProvider, $urlRouterProvider)
{
    $stateProvider
        .state('list', {
            url: "/list",
            templateUrl: "Partials/list.html"
        })

        .state('addNewCar', {
            url: "/addNewCar",
            templateUrl: "Partials/addNew.html"
        });

        $urlRouterProvider.otherwise("/list");
});