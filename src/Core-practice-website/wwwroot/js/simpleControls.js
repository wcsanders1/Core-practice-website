(function () {
    "use strict";

    angular.module("simpleControls", [])
        .directive("waitCursor", waitCursor);

    function waitCursor() {
        return {
            scope: {
                show: "=displayWhen"
            },
            restrict: "E",   // this restriction means it can only be an element, not an attr
            templateUrl: "/views/waitCursor.html"
        };
    }
})();