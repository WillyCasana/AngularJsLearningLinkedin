var miAppAngular=angular.module('navegacion',['ngRoute']);

miAppAngular.config(['$routeProvider',function($routeProvider){
    $routeProvider.when('/',{
        templateUrl:'plantillas/inicio.html',
        controller:'inicio'
    })
    .when('/galeria',{
        templateUrl:'plantillas/galeria.html',
        controller:'inicio'
    })
    .when('/confirmacion',{
        templateUrl:'plantillas/confirmacion.html',
        controller:'inicio'
    })
    .when('/404',{
        templateUrl:'plantillas/404.html',
        controller:'inicio'
    })
    .otherwise({
        redirectTo:'/404'
    })
}]);

miAppAngular.constant('configuracionGlobal',{
    'nombreDelSitio':'Corporación WCS',
    'api_url':'http://localhost:50931/api/',
    'carpeta_imagenes':'imagenes/'
})