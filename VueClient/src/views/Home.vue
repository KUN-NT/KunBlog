<template>
  <div>
    <el-row class="slider">
      <el-col :span="18" :offset="3">
        <Slider></Slider>
      </el-col>
    </el-row>
    <el-row>
      <el-col :span="12" :offset="3">
        <Article></Article>
      </el-col>
      <el-col :span="5" :offset="1">
        <NavSidebar></NavSidebar>
      </el-col>
    </el-row>
  </div>
</template>

<script>
import Slider from "../components/Slider";
import Article from "../components/Article";
import NavSidebar from "../components/Sidebar";

export default {
  components: {
    Slider,
    Article,
    NavSidebar
  }
};
</script>

<style>
  .slider{
    margin: 10px 0;
  }
</style>