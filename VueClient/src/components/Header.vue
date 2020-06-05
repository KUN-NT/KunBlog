<template>
  <el-menu :default-active="activeIndex" mode="horizontal">
        <el-menu-item v-for="(menu,index) in menuData" :key="index" :index="menu.menU_ID">
          <a href="javascript:;" target="_self" @click="goPage(menu.menU_PATH)">{{menu.menU_NAME}}</a>
        </el-menu-item>
        <el-menu-item style="float:right">
          <el-input placeholder="请输入内容" v-model="input" class="input-with-select">
            <el-select v-model="select" slot="prepend" placeholder="请选择">
              <el-option label="文章" value="article"></el-option>
              <el-option label="分类" value="type"></el-option>
              <el-option label="标签" value="tag"></el-option>
            </el-select>
            <el-button slot="append" icon="el-icon-search" @click="searchData"></el-button>
          </el-input>
        </el-menu-item>
  </el-menu>
</template>

<script>
export default {
  data() {
    return {
      activeIndex: "home",
      menuData: [],
      input: "",
      select: "article"
    };
  },
  methods: {
    getMenuList() {
      this.$axios.get("http://localhost:5000/api/menu/admin").then(res => {
        this.menuData = res.data;
      });
    },
    goPage(path) {
      this.$router.push({ path: path });
    },
    searchData(){
      this.$router.push({ path: `/search/${this.select}/${this.input}`});
    }
  },
  mounted() {
    this.getMenuList();
  }
};
</script>

<style>
.el-select .el-input {
  width: 100px;
}
.input-with-select .el-input-group__prepend {
  background-color: #fff;
}
</style>