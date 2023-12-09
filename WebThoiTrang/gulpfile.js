var gulp = require('gulp'),
    cssmin = require("gulp-cssmin")
    rename = require("gulp-rename");
const sass = require('gulp-sass')(require('sass'));
// tạo 1 tác vụ tên là default
gulp.task('default', function () {
    return gulp.src('assets/default/site.scss') // nhiệm vụ là convert file scss sang file css
        .pipe(sass().on('error', sass.logError))
        // .pipe(cssmin())
        .pipe(rename({
            // suffix: ".min"
        }))
        .pipe(gulp.dest('wwwroot/css/')); // kết quả lưu trử vào thư mục css
    });

gulp.task("watch", function () { // dùng để giám sát sự thay đổi của file
   gulp.watch('assets/default/*.scss', gulp.series('default'));
});    

// chạy lệnh bằng cách gulp sass