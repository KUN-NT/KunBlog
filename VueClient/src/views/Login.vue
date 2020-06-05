<template>
  <div>
    <el-row>
      <el-input class="input" placeholder="请输入账号" v-model="userId" clearable></el-input>
    </el-row>
    <el-row>
      <el-input class="input input_password" placeholder="请输入密码" v-model="password" show-password></el-input>
    </el-row>
    <el-row>
      <el-button class="btn_login" type="primary" @click="Login">登 录</el-button>
    </el-row>
    <p>{{msg}}</p>
  </div>
</template>
<script>
export default {
  data() {
    return {
      userId: "",
      password: "",
      msg: ""
    };
  },
  methods: {
    Login() {
      this.$axios({
        method: "get",
        url: "http://localhost:5000/api/user/"+this.userId+"/"+this.password
      }).then(res=> {
          this.$router.push({path:"home/"+this.userId})
        })
        .catch(error=> {
          this.msg=error;
        });
    }
  }
};
</script>

<style>
.input {
  width: 40%;
}
.input_password {
  margin: 20px 0;
}
.btn_login {
  width: 40%;
}
</style>