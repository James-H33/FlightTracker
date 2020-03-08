const { src, dest, parallel, watch } = require('gulp');
var sass = require('gulp-sass');

function css() {
  return src('./wwwroot/styles/**/*.scss')
    .pipe(sass().on('error', sass.logError))
    .pipe(dest('./wwwroot/css'))
}

function watchCss(cb) {
    css();
    watch('./wwwroot/styles/**/*.scss', css);
    cb();
}

exports.css = css;
exports.watchCss = watchCss;
exports.default = parallel(css);