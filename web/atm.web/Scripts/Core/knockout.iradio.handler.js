

// This function is requiured for below.
ko.subscribable.fn.subscribeChanged = function (callback) {
    var that = this;

    if (!that.previousValueSubscription) {
        that.previousValueSubscription = this.subscribe(function (_oldValue) {
            that.oldValue = _oldValue;
        }, that, 'beforeChange');
    }
    var subscription = that.subscribe(function (latestValue) {
        callback(latestValue, that.oldValue);
    }, that);

    var protoDispose = subscription.dispose;
    subscription.dispose = function () {
        if (protoDispose) {
            protoDispose.call(this);
        }
        if (that.previousValueSubscription) {
            that.previousValueSubscription.dispose();
        }
        delete that.oldValue;
    }

    return subscription;
};


ko.bindingHandlers.iRadioBox = {
    init: function (element, valueAccessor, allBindingsAccessor, viewModel, bindingContext) {
        var $el = $(element);
        var observable = valueAccessor();
        
        $el.iCheck({
            checkboxClass: 'icheckbox_minimal',
            radioClass: 'iradio_minimal',
            increaseArea: '20%', // optional
            inheritClass: true
        });

        //Checkbox listing
        var parentCheck = $('.list-parent-check');
        var listCheck = $('.list-check');

        parentCheck.on('ifChecked', function () {
            $(this).closest('.list-container').find('.list-check').iCheck('check');
        });

        parentCheck.on('ifClicked', function () {
            $(this).closest('.list-container').find('.list-check').iCheck('uncheck');
        });

        listCheck.on('ifChecked', function () {
            var parent = $(this).closest('.list-container').find('.list-parent-check');
            var thisCheck = $(this).closest('.list-container').find('.list-check');
            var thisChecked = $(this).closest('.list-container').find('.list-check:checked');

            if (thisCheck.length == thisChecked.length) {
                parent.iCheck('check');
            }

        });

        listCheck.on('ifUnchecked', function () {
            var parent = $(this).closest('.list-container').find('.list-parent-check');
            parent.iCheck('uncheck');
        });

        listCheck.on('ifChanged', function () {
            var thisChecked = $(this).closest('.list-container').find('.list-check:checked');
            var showon = $(this).closest('.list-container').find('.show-on');
            if (thisChecked.length > 0) {
                showon.show();
            }
            else {
                showon.hide();
            }
        });

        var enabledSubs = null;
        var enable = allBindingsAccessor().enable;
        if (enable != undefined) {
            if (enable()) {
                $el.iCheck('enable');
            }
            else {
                $el.iCheck('disable');
            }
            enabledSubs = enable.subscribeChanged(function (newValue, oldValue) {
                if (newValue != oldValue) {
                    $el.iCheck('update');
                }
            });
        }

        ko.utils.domNodeDisposal.addDisposeCallback(element, function () {
            if (enabledSubs != null) {
                enabledSubs.dispose();
                enabledSubs = null;
            }
            $el.iCheck('destroy');
        });

        // ifChecked handles tabs and clicks
        $el.on('ifChecked', function (e) {
            observable(true);
        });
        $el.on('ifUnchecked', function (e) {
            observable(false);
        });
        
        ko.bindingHandlers.iRadioBox.update(element, valueAccessor, allBindingsAccessor, viewModel, bindingContext);
    },
    update: function (element, valueAccessor, allBindingsAccessor, viewModel, bindingContext) {
        // This update handles both the reverting of values from cancelling edits, and the initial value setting.
        var $el = $(element);
        var value = ko.unwrap(valueAccessor());

        // Get names of element
        //console.log($el.attr('name'));
        
        if (value === $el.val() || value === true) {
            $el.iCheck('check');
        } else if (value !== $el.val() || value === null || value === false || value === "") { // Handle clearing the value on reverts.
            $el.iCheck('uncheck');
        }
    }
};