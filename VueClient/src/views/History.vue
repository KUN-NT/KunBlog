<template>
  <div>
    <el-row>
      <el-col :span="18" :offset="3">
        <Bread>
          <slot>
            <el-breadcrumb-item>时间线</el-breadcrumb-item>
          </slot>
        </Bread>
        <el-timeline>
          <el-timeline-item
            v-for="(article,index) in articleData"
            :key="index"
            :timestamp="article.creatE_DATE"
            placement="top"
          >
            <a href="javascript:;" @click="getarticle(article.articlE_ID)">
              <el-card shadow="hover">
                <span class="blog_font_small">{{article.articlE_TITLE}}</span>
                <p>{{article.articlE_CONTENT}}</p>
              </el-card>
            </a>
          </el-timeline-item>
        </el-timeline>
      </el-col>
    </el-row>
  </div>
</template>

<script>
import Bread from "../components/Bread";

export default {
  data() {
    return {
      articleData: []
    };
  },
  methods: {
    getArticleList() {
      this.$axios.get("http://localhost:5001/api/article").then(res => {
        this.articleData = res.data;
        // this.articleData = this.articleData.sort(function(a, b) {
        //   return (
        //     Date.parse(b.datetime.replace(/-/g, "/")) -
        //     Date.parse(a.datetime.replace(/-/g, "/"))
        //   );
        // });
      });
    },
    getarticle(articleId) {
      this.$router.push({ path: "/article/" + articleId });
    }
  },
  mounted() {
    this.getArticleList();
  },
  components: {
    Bread
  }
};
</script>