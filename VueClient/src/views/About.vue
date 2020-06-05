<template>
  <div>
    <el-row>
      <el-col :span="18" :offset="3">
        <Bread>
          <slot>
            <el-breadcrumb-item>关于我</el-breadcrumb-item>
          </slot>
        </Bread>
      </el-col>
    </el-row>
    <el-row>
      <el-col :span="18" :offset="3">
        <el-card shadow="hover">
          <el-row class="blog_icon">
            <el-col :span="4" :offset="10">
              <el-avatar
                :size="size"
                src="https://pic.cnblogs.com/avatar/1195605/20200315104809.png"
              ></el-avatar>
            </el-col>
          </el-row>
          <el-row>
              <el-col :span="20" :offset="2">
                <h2>语言能力</h2>
                <p>外语： 英语　一般 粤语水平： 一般</p>
                <h3>其它外语能力：</h3>
                <p>国语水平： 优秀</p>
　　            <h2>工作能力及其他专长</h2>
　　            <p>1.具有面向对象思想，扎实的编程功底以及良好的编码习惯;</p>
　　            <p>2.熟练应用Struts+Hibernate，SSH2框架和MVC三层架构开发模式;</p>
　　            <p>3.熟练Oracle数据库的操作，能够编写存储过程，熟悉Mysql和SqlServer数据库;</p>
　　            <p>4.熟练Tomcat服务器的部署及应用;</p>
　　            <p>5.熟悉版本管理器SVN;</p>
　　            <p>6.熟练使用Jsp，HTML，JavaScript，Jquery，Ajax，Css等WEB客户端技术;</p>
　　            <p>7.了解设计模式，代码重构和项目过程管理，能够编写文档。</p>
              </el-col>
          </el-row>
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
      size: 150
    };
  },
  components: {
    Bread
  }
};
</script>

<style>
.progress {
  margin-top: 10px;
}
.blog_icon{
    margin-top: 50px;
}
</style>