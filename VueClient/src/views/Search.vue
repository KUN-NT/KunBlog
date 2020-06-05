<template>
  <div>
    <el-row>
      <el-col :span="18" :offset="3">
        <Bread>
          <slot>
            <el-breadcrumb-item>查询结果</el-breadcrumb-item>
          </slot>
        </Bread>
      </el-col>
    </el-row>
    <el-row>
      <el-col :span="18" :offset="3">
        <el-card  class="search_result" shadow="hover" v-for="(article,index) in articleData" :key="index">
          <div slot="header"  @click="getArticle(article.articlE_ID)">
            <span>{{article.articlE_TITLE}}</span>
          </div>
          <div>{{article.articlE_CONTENT}}</div>
        </el-card>
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
    getArticleList(type, value) {
      this.$axios
        .get(`http://localhost:5001/api/article/${type}/${value}`)
        .then(res => {
          this.articleData = res.data;
        });
    },
    getArticle(articleId) {
      this.$router.push({ path: "/article/" + articleId });
    },
  },
  components: {
    Bread
  },
  mounted() {
    this.getArticleList(this.$route.params.type, this.$route.params.value);
  }
};
</script>

<style>
.search_result {
    margin-bottom: 20px;
}
</style>