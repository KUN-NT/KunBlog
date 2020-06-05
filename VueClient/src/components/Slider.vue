<template>
  <el-carousel trigger="click" class="slider">
    <el-carousel-item v-for="(item,index) in articleData" :key="index">
      <div @click="getArticle(item.articlE_ID)">
        <h3 class="small">{{ item.articlE_TITLE }}</h3>
      </div>
    </el-carousel-item>
  </el-carousel>
</template>

<script>
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
        this.articleData = this.articleData.filter(p => p.iS_TOP=='Y');
      });
    },
    getArticle(articleId){
      this.$router.push({path:"/article/"+articleId})
    }
  },
  mounted() {
    this.getArticleList();
  }
};
</script>

<style>
.el-carousel__item {
  text-align: center;
  border-radius: 5px;
}
.el-carousel__item h3 {
  color: #fff;
  font-size: 30px;
  opacity: 0.75;
  line-height: 300px;
  letter-spacing:30px;
  margin: 0;
}

.el-carousel__item:nth-child(2n) {
  background: #ffffff url('../../static/2.png') no-repeat center center;
}

.el-carousel__item:nth-child(2n + 1) {
  background: #ffffff url('../../static/1.png') no-repeat center center;
}

.slider:hover{
    cursor:pointer;
}
</style>