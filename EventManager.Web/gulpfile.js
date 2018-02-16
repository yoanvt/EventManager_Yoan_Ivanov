/// <binding BeforeBuild='less' ProjectOpened='less, watch-less' />
/*
This file is the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. https://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp'),
    less = require("gulp-less"),
    watchLess = require('gulp-watch-less');

const webroot = './wwwroot/';

gulp.task('less', function () {
    return gulp.src(webroot + 'css/**/*.less')
        .pipe(less())
        .pipe(gulp.dest(webroot + '/css'));
});

gulp.task("watch-less", function () {
    return watchLess(webroot + 'css/**/*.less')
        .pipe(less())
        .pipe(gulp.dest(webroot + '/css'));
});