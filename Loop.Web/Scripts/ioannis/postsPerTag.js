var app = angular.module('PostsPerTagApp', []);
app.filter("formatDate",
    function ()
    {
        return function (dateFromJson){ return dateFromJson.slice(6, -2) }
    }
)
app.controller("PostsPerTagController", function ($scope, $http, $attrs) {
    $http.get("/Tags/GetTagById/" + $attrs.tagId).then(
        function (response) {
            console.log(response.data[0]);
            $scope.postsPerTag = response.data[0];
        }
        , function (response) {
            console.log(response.status);
        }
    );

    $scope.postFilter = function (post) {
        if ($scope.model_search === undefined || $scope.model_search === null || $scope.model_search === "" || post === undefined) return true;
        return post.Title.toLowerCase().includes($scope.model_search.toLowerCase());
    }

});
