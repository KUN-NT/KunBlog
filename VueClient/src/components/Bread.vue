<template>
  <el-card shadow="hover" class="bread">
    <el-breadcrumb separator-class="el-icon-arrow-right">
      <el-breadcrumb-item :to="{ path: '/' }">首页</el-breadcrumb-item>
      <slot></slot>
    </el-breadcrumb>
  </el-card>
</template>

<style>
.bread {
  margin: 20px 0;
  font-size: 16px;
}
</style>