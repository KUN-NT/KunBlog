<template>
  <div id="app">
    <el-row class="header box">
      <el-col :span="18" :offset="3">
        <NavHeader></NavHeader>
      </el-col>
    </el-row>
    <router-view />
    <el-row>
      <el-col :span="18" :offset="3">
        <el-divider>
          <i class="el-icon-s-flag"></i>
        </el-divider>
        <div class="footer">
          <NavFooter></NavFooter>
        </div>
      </el-col>
    </el-row>
  </div>
</template>

<script>
import NavHeader from "./components/Header";
import NavFooter from "./components/Footer";

export default {
  name: "App",
  components: {
    NavHeader,
    NavFooter
  },
  methods:{
    handleScroll(){
      let t = $("body, html").scrollTop(); // 目前监听的是整个body的滚动条距离
      if (t > 0) {
        $(".box").addClass("box-active");
      } else {
        $(".box").removeClass("box-active");
      }
    }
  },
  mounted: function() {
    window.addEventListener("scroll", this.handleScroll, true); // 监听（绑定）滚轮滚动事件
  },
  destroyed: function() {
    window.removeEventListener("scroll", this.handleScroll); //  离开页面清除（移除）滚轮滚动事件
  }
};
</script>

<style>
#app {
  font-family: "Avenir", Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
}
body {
  padding: 0;
  margin: 0;
}
a {
  text-decoration: none;
}
.header {
  margin-bottom: 10px;
}
.footer {
  margin: 10px;
  text-align: center;
  color: #ccc;
}
.box {
  position: relative;
  height: 80px;
  width: 100%;
  z-index: 999;
}
.box-active {
  position: fixed;
  top: 0;
}
.blog_font{
  color:#0099cc;
  font-size: 20px;
  font-weight: 700;
  letter-spacing:3px;
}
.blog_font_small{
  font-size: 16px;
  font-weight: 700;
  letter-spacing:2px;
}
</style>
