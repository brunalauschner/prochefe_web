<template>
  <div>
      <div class="links2">
        <router-link class="link" to="/">Home</router-link>
        <router-link class="link" to="/sobrenos">Sobre Nós</router-link>
        <router-link class="link" to="/cardapio">Cardápio</router-link>
        <router-link class="link" to="/delivery">Delivery</router-link>
        <router-link class="link" to="/sugestoes">Sugestões</router-link>
        <router-link class="link" to="/entrar">Clientes</router-link>
        <router-link class="link" to="/intranet">Intranet</router-link>
      </div>
      <div>
        <h2>Entrar</h2>
        <span>Login:</span>
        <input type="text" v-model="logi"><br>
        <span>Senha:</span>
        <input type="text" v-model="senh"><br>
        <button @click="entrar">Entrar</button>
      </div>
  </div>
</template>

<script>
const axios = require('axios')

export default {
    data: function(){
        return {
            adms: [],
            funcs: [],
            logi: '',
            senh: '',
            login2: [],
            login3: []
        }
    }, methods: {
        entrar: function(){
            this.login2 = this.funcs.find(log => this.logi == log.login && this.senh == log.senha)
            this.login3 = this.adms.find(logq => this.logi == logq.login && this.senh == logq.senha)
            if(this.login2 != null){
                this.$store.state.funcSel = this.login2
            }
            else if(this.login3 != null){
                this.$store.state.admSel = this.login3
            }
            this.$router.push("/dashboard")
        }
    }, mounted(){
        axios.get("http://localhost:65343/api/Funcionario").then(fu => this.funcs = fu.data)
        axios.get("http://localhost:65343/api/Administrador").then(ad => this.adms = ad.data)
    }
}
</script>

<style>

</style>