(function() {
    var app = angular.module('app');

    app.controller('app.controllers.views.home', [
        '$scope', function($scope) {
            //...
        }
    ]);

    app.controller('sts.controllers.views.customer.list', [
        '$scope', 'abp.services.extramile.customer',
        function ($scope, customerService) {
            var vm = this;

            vm.localize = abp.localization.getSource('ExtramileManager');

            

            $scope.selectedCustomerState = 0;

            vm.formCollapsed = true;
            vm.form = {};
            
            vm.create = false;
            vm.show = false;
            
            vm.customerCreated = false;
            vm.customerUpdated = false;

            vm.selectedCustomerType = 1;

            vm.customers = {};

            vm.viewCustomer = function (customer) {
                
                if (vm.show || vm.formCollapsed)
                    vm.formCollapsed = !vm.formCollapsed;
                vm.show = true;
                vm.create = false;
                if (!vm.formCollapsed) {
                    vm.form = customer;
                }
            }

            vm.editCustomer = function (customer) {
                
                if (vm.create || vm.show) {
                    vm.formCollapsed = false;
                    vm.create = false;
                } else
                    vm.formCollapsed = !vm.formCollapsed;
                
                vm.show = false;
                if (!vm.formCollapsed) {
                    $.blockUI();
                    vm.form = angular.copy(customer);
                    $.unblockUI();
                    //customerService.getCustomer({ "Id": customerId })
                    //.success(function (data) {
                        
                    //    vm.form = data;
                    //    $.unblockUI();
                    //})
                    //.error(function(date){
                    //    vm.form={};
                    //    alert('something failed');
                    //    $.unblockUI();
                    //});
                    
                    

                }
            }

            vm.deleteCustomer = function (customer) {
                $.blockUI();
                customer.estado = 3;
                customerService.updateCustomer(customer)
                .success(function (data) {
                    vm.refreshCustomers(vm.selectedCustomerType);
                    $.unblockUI();
                })
                
                
            }

            vm.createCustomer = function () {
                vm.show = false;
                if (!vm.create) {
                    vm.create = true;
                    vm.formCollapsed = false;
                } else
                    vm.formCollapsed = !vm.formCollapsed;


                if (!vm.formCollapsed) {
                    vm.form = {"tipo":1};
                }
            }

            vm.saveCustomer = function () {
                customerService.saveCustomer(vm.form)
                .success(function (data) {
                    vm.formCollapsed = true;
                    vm.refreshCustomers(vm.selectedCustomerType);
                    vm.customerCreated = true;
                    $.unblockUI();
                })
                .error(function(date){
                    vm.form={};
                    alert('something failed');
                    $.unblockUI();
                });

            }

            vm.updateCustomer = function () {
                customerService.updateCustomer(vm.form)
                .success(function (data) {
                    vm.formCollapsed = true;
                    vm.refreshCustomers(vm.selectedCustomerType);
                    vm.customerUpdated = true;
                    $.unblockUI();
                })
                .error(function (date) {
                    vm.form = {};
                    alert('something failed');
                    $.unblockUI();
                });

            }


            $scope.$watch('vm.selectedCustomerType', function (value) {
                vm.refreshCustomers(value);
            });

            vm.refreshCustomers = function (value) {
                customerService.getCustomers({"tipo":value})
                    .success(function (data) {
                        vm.customers = data;
                    });
            };

            //vm.changeTaskState = function (task) {
            //    var newState;
            //    if (task.state == 1) {
            //        newState = 2; //Completed
            //    } else {
            //        newState = 1; //Active
            //    }

            //    taskService.updateTask({
            //        taskId: task.id,
            //        state: newState
            //    }).success(function () {
            //        task.state = newState;
            //        abp.notify.info(vm.localize('TaskUpdatedMessage'));
            //    });
            //};

            vm.getCustomerCountText = function () {
                return vm.customers.length;
            };
        }
    ]);
})();