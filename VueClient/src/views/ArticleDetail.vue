<template>
  <div>
    <el-row>
      <el-col :span="18" :offset="3">
        <Bread>
          <slot>
            <el-breadcrumb-item>文章详情</el-breadcrumb-item>
          </slot>
        </Bread>
      </el-col>
    </el-row>
    <el-row>
      <el-col :span="18" :offset="3">
        <el-card shadow="hover">
          <div slot="header">
            <span class="blog_font">{{article.articlE_TITLE}}</span>
          </div>
          <div>{{article.articlE_CONTENT}}</div>
        </el-card>
      </el-col>
    </el-row>
    <el-row class="author">
      <el-col :span="18" :offset="3">
        <el-card shadow="hover">
          <el-row :gutter="20">
            <el-col :span="1">
              <el-avatar
                :size="imgSize"
                shape="square"
                src="https://pic.cnblogs.com/avatar/1195605/20200315104809.png"
              ></el-avatar>
            </el-col>
            <el-col :span="10" :offset="1" class="blog_font_small">
              <p>作者:&nbsp;{{article.useR_ID}}</p>
              <p>创建时间:&nbsp;{{article.creatE_DATE}}</p>
            </el-col>
          </el-row>
        </el-card>
      </el-col>
    </el-row>
    <el-row class="tag">
      <el-col :span="18" :offset="3">
        <span  v-if="tagList.length > 0">
          标签:&nbsp;
          <el-tag  class="tag_item"
            v-for="(tag,index) in tagList"
            :key="index"
            :type="tag.taG_STYLE"
            @click="clickTag(tag.taG_ID)"
          >{{tag.taG_NAME}}</el-tag>
        </span>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <span v-if="typeList.length > 0">
          分类:&nbsp;
          <el-tag class="type_item"
            v-for="(type,index) in typeList"
            :key="index"
            :type="type.typE_STYLE"
            @click="clickType(type.typE_ID)"
          >{{type.typE_NAME}}</el-tag>
        </span>
      </el-col>
    </el-row>
  </div>
</template>

<script>
import Bread from "../components/Bread";

export default {
  data() {
    return {
      imgSize: 80,
      article: {},
      tagList: [],
      typeList: []
    };
  },
  methods: {
    getArticle() {
      this.$axios
        .get(
          "http://localhost:5001/api/article/" + this.$route.params.articleId
        )
        .then(res => {
          this.article = res.data;
        });
    },
    getTagList() {
      this.$axios
        .get("http://localhost:5001/api/tag/" + this.$route.params.articleId)
        .then(res => {
          this.tagList = res.data;
        });
    },
    getTypeList() {
      this.$axios
        .get("http://localhost:5001/api/type/" + this.$route.params.articleId)
        .then(res => {
          this.typeList = res.data;
        });
    },
    goBack() {
      this.$router.go(1);
    },
    clickTag(tagId) {
      this.$router.push({ path: `/search/tag/${tagId}` });
    },
    clickType(typeId) {
      this.$router.push({ path: `/search/type/${typeId}` });
    }
  },
  components: {
    Bread
  },
  mounted() {
    this.getArticle();
    this.getTagList();
    this.getTypeList();
  }
};
</script>

<style>
.author {
  margin: 20px 0;
}
</style>