var app = angular.module('TagsApp', []);
app.controller("TagsController", function ($scope, $http) {
    $http.get("/Tags/GetTags").then(
        function (response) {
            $scope.tags = response.data;
        }
        , function (response) {
            console.log(response.status);
        }
    );

    $scope.tagFilter = function (tag) {
        if ($scope.model_search === undefined || $scope.model_search === null || $scope.model_search === "" || tag === undefined) return true;
        return tag.Title.toLowerCase().includes($scope.model_search.toLowerCase());
    }

});