(function () {
    'use strict';

    var localize = abp.localization.getSource('ExtramileManager');

    var app = angular.module('app', [
        'ngAnimate',
        'ngRoute',
        'ngSanitize',

        'ui.bootstrap',
        'ui.jq',

        'abp'
    ]);

    app.constant('routes', [
             {
                 url: '/', //default
                 show: true,
                 config: {
                     templateUrl: '/App/Main/views/home/home.cshtml',
                     menuText: localize('Home'),
                     menuItem: 'HomePage'
                 }
             },
             {
                 url: '/clientes', //default
                 show: true,
                 config: {
                     templateUrl: '/App/Main/views/clientes/list.cshtml',
                     menuText: localize('Clientes'),
                     menuItem: 'Clientes'
                 }
             },
             {
                 url: '/proveedores', //default
                 show: true,
                 config: {
                     templateUrl: '/App/Main/views/proveedores/list.cshtml',
                     menuText: localize('Proveedores'),
                     menuItem: 'Proveedores'
                 }
             },
            {
                url: '/about',
                show: false,
                config: {
                    templateUrl: '/App/Main/views/about/about.cshtml',
                    menuText: localize('Acerca'),
                    menuItem: 'About'
                }
            },
            {
                url: '/config',
                show: false,
                config: {
                    templateUrl: '/App/Main/views/config.cshtml',
                    menuText: localize('Config'),
                    menuItem: 'Config'
                }
            }
            ,
            {
                url: '/login',
                show: false,
                config: {
                    templateUrl: '/App/Main/views/login.cshtml',
                    menuText: localize('Login'),
                    menuItem: 'Login'
                }
            }
        ]);

    app.config([
        '$routeProvider', 'routes',
        function ($routeProvider, routes) {
            routes.forEach(function (route) {
                $routeProvider.when(route.url, route.config);
            });

            $routeProvider.otherwise({
                redirectTo: '/'
            });
        }
    ]);

    app.run([
        '$rootScope',
        function ($rootScope) {
            $rootScope.$on('$routeChangeSuccess', function (event, next, current) {
                if (next && next.$$route) {
                    $rootScope.activeMenu = next.$$route.menuItem; //Used in layout.cshtml to make selected menu 'active'.
                }
            });
        }
    ]);
})();