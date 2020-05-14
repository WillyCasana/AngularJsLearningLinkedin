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
    .when('/mapa',{
        templateUrl:'plantillas/mapa.html',
        controller:'inicio'
    })
    .when('/contacto',{
        templateUrl:'plantillas/contacto.html',
        controller:'inicio'
    })
    .when('/404',{
        templateUrl:'plantillas/404.html',
        controller:'inicio'
    })
    .when('/detalles/:empleadoId',{
        templateUrl:'plantillas/detalles.html',
        controller:'detalles'
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