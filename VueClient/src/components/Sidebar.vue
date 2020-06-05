<template>
  <div>
    <el-card  class="sidebar_type" shadow="hover" v-if="typeList.length > 0">
        <div slot="header">
            <span style="font-weight:700;">分类</span>
        </div>
        <div>
          <el-badge class="type_item" v-for="(type,index) in typeList" :key="index" :value="parseInt(type.articlE_NUM)" :max="99">
          <el-tag 
            :type="type.typE_STYLE"
            @click="clickType(type.typE_ID)"
          >{{type.typE_NAME}}</el-tag>
          </el-badge>
        </div>
     </el-card>
     <el-card  class="sidebar_tag" shadow="hover" v-if="tagList.length > 0">
        <div slot="header">
            <span style="font-weight:700;">标签</span>
        </div>
        <div>
          <el-badge class="tag_item" v-for="(tag,index) in tagList" :key="index" :value="parseInt(tag.articlE_NUM)" :max="99">
          <el-tag 
            :type="tag.taG_STYLE"
            @click="clickTag(tag.taG_ID)"
          >{{tag.taG_NAME}}</el-tag>
          </el-badge>
        </div>
     </el-card>
  </div>
</template>

<script>
export default {
  data() {
    return{
      typeList:[],
      tagList:[]
    }
  },
  methods: {
    getTagList() {
      this.$axios
        .get("http://localhost:5001/api/tag")
        .then(res => {
          this.tagList = res.data;
        });
    },
    getTypeList() {
      this.$axios
        .get("http://localhost:5001/api/type")
        .then(res => {
          this.typeList = res.data;
        });
    },
    clickTag(tagId) {
      this.$router.push({ path: `/search/tag/${tagId}` });
    },
    clickType(typeId) {
      this.$router.push({ path: `/search/type/${typeId}` });
    }
  },
  mounted(){
    this.getTagList();
    this.getTypeList();
  }
};
</script>

<style>
  .sidebar_type,.sidebar_tag{
    margin-bottom: 10px;
  }
  .type_item,.tag_item{
    margin: 0 15px 20px 15px;
  }
  .type_item:hover,.tag_item:hover{
    cursor:pointer;
  }
</style>