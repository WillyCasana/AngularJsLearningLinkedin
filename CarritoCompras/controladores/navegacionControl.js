miAppAngular.controller('navegacionControl',function($scope,$location,configuracionGlobal){
    $scope.config=configuracionGlobal;
    $scope.esActivo =function(rutaActual){
        if ($location.path() === rutaActual) 
        {
            return "active";
        }else
        {
            return "";
        }
        
    }
});