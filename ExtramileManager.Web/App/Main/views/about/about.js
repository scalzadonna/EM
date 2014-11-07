(function() {
    var app = angular.module('app');

    var controllerId = 'app.controllers.views.about';
    app.controller(controllerId, [
        '$scope', function($scope) {
            //...
            this.greet = 'hi there';
        }
    ]);

    app.controller('app.controllers.views.new', [
        '$scope', function ($scope) {
            //...
            this.greet = 'hi there';
        }
    ]);
})();