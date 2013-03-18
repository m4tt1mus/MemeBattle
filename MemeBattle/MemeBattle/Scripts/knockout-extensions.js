/*
* Knockout Extensions v1
*/

// add data- attributes to a tag
ko.bindingHandlers.dataDash = {
    update: function (element, valueAccessor, allBindingsAccessor, viewModel, bindingContext) {
        var value = valueAccessor();
        $(element).data(value.name, value.content);
    }
};

// sets the src of an image and its height
ko.bindingHandlers.img = {
    update: function (element, valueAccessor, allBindingsAccessor, viewModel, bindingContext) {
        var values = valueAccessor();
        element.src = values.baseUrl + values.pic;
        $(element).width(values.width);
    }
};