miAppAngular.controller('detalles',function($scope,$http,$routeParams,configuracionGlobal,$location){
    $http.get(configuracionGlobal.api_url + "EmpleadoNg/",{
        params:{id:$routeParams.empleadoId}
    })
    .then(function(respuesta){
        $scope.empleado=respuesta.data;
    })


    $scope.guardarInfo= function(){
        $http({
            url:configuracionGlobal.api_url  + "EmpleadoNg/",
            method:"Post",
            data:$scope.empleado
        }).then(function(respuesta){
            $location.path("/")
        })
    }
});