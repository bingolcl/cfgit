<?php
  //Buffer larger content areas like the main page content
  ob_start();
?>
        <div class="col-md-8 col-sm-8 col-xs-12">
          <div class="row">
            <div class="col-md-12 col-sm-12 col-xs-12">
              <!-- single-blog start -->
              <article class="blog-post-wrapper">
                <div class="post-information">
                  <h3>2019 博域夏令營</h3>
                  <div class="entry-meta">
                    <span class="author-meta"><i class="fa fa-user"></i>Anna Yang</span>
                    <span><i class="fa fa-clock-o"></i> march 13, 2019</span>
                    <span><i class="fa fa-save"></i><a href="files/BUSP_2019.pdf" download>下载PDF</a></span>
                  </div>
                  <div class="entry-content" >
                  <embed src="files/BUSP_2019.pdf" type="application/pdf" width="100%" height="800px" />
                  </div>
                </div>
              </article>
              <div class="clear"></div>
              <!-- single-blog end -->
            </div>
          </div>
        </div>
<?php
  //Assign all Page Specific variables
  $pageblogcontent = ob_get_contents();
  ob_end_clean();
  $pagetitle = "博域夏令營";
  //Apply the template
  include("blog-master.php");
?>