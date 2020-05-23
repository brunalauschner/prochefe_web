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
      <input type="text" v-model="logs"><br>
      <span>Senha:</span>
      <input type="text" v-model="sens"><br>
      <button @click="entrar">Entrar</button>
  </div>
  <div>
      <span>Não possui cadastro?</span>
      <router-link to="/cadastro">Clique aqui</router-link>
  </div>
  </div>
</template>

<script>
const axios = require('axios')

export default {
    data: function(){
        return {
            clientes: [],
            logs: '',
            sens: '',
            login1: []
        }
    }, methods: {
        entrar: function(){
            this.login1 = this.clientes.find(log => this.logs == log.login && this.sens == log.senha)
            this.$store.state.clienteSel = this.login1
            console.log(this.login1)
            console.log(this.$store.state.clienteSel)
            this.$router.push("/dados")
        }
    }, mounted(){
        axios.get("http://localhost:65343/api/Cliente").then(cli => this.clientes = cli.data)
    }
}
</script>

<style>

</style>