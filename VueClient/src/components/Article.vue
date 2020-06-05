<template>
  <div>
    <el-card class="box-card" shadow="hover" v-for="(article,index) in articleData" :key="index">
      <div slot="header" class="clearfix" @click="getArticle(article.articlE_ID)">
        <span>{{article.articlE_TITLE}}</span>
      </div>
      <div class="text item">{{article.articlE_CONTENT}}</div>
    </el-card>

    <el-pagination
      background
      layout="prev, pager, next"
      :total="total"
      @current-change="quietPage($event)"
    ></el-pagination>
  </div>
</template>

<script>
export default {
  data() {
    return {
      articleData: [],
      total: 0,
      pageIndex: 1,
      pageSize: 10
    };
  },
  methods: {
    getArticleList() {
      this.$axios
        .get(`http://localhost:5001/api/article/page/${this.pageIndex}/${this.pageSize}`)
        .then(res => {
          this.articleData = res.data;
          this.$axios
            .get("http://localhost:5001/api/article/count")
            .then(res => {
              this.total = res.data;
            });
        });
    },
    getArticle(articleId) {
      this.$router.push({ path: "/article/" + articleId });
    },
    quietPage(e) {
      this.pageIndex = e;
      this.getArticleList();
    }
  },
  mounted() {
    this.getArticleList();
  }
};
</script>

<style>
.box-card {
  margin-bottom: 10px;
}

.text {
  font-size: 14px;
}

.item {
  margin-bottom: 18px;
}

.clearfix:before,
.clearfix:after {
  display: table;
  content: "";
}
.clearfix:after {
  clear: both;
}
.clearfix:hover {
  cursor: pointer;
}
</style>