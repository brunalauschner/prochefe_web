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
        <span>Nome:</span>
        <input type="text" v-model="nomeA" ><br>
        <span>CPF:</span>
        <input type="text" v-model="cpfA"><br>
        <span>Login:</span>
        <input type="text" v-model="loginA"><br>
        <span>Senha:</span>
        <input type="text" v-model="senhaA"><br>
        <span>Telefone:</span>
        <input type="text" v-model="telefoneA"><br>
        <span>E-mail:</span>
        <input type="text" v-model="emailA"><br>
        <span>Salário:</span>
        <input type="text" v-model="salarioA"><br>
        <button @click="alterar">Alterar</button>
      </div>
  </div>
  
</template>

<script>
const axios = require('axios')

export default {
    data: function(){
        return {
            admiSel: this.$store.state.admSel,
            nomeA: this.$store.state.admSel.nome,
            cpfA: this.$store.state.admSel.cpf,
            loginA: this.$store.state.admSel.login,
            senhaA: this.$store.state.admSel.senha,
            telefoneA: this.$store.state.admSel.telefone,
            emailA: this.$store.state.admSel.email
        }
    }, methods: {
        alterar: function(){

            axios.put("http://localhost:65343/api/Administrador/"+this.admiSel.id, {
                nome: this.nomeA,
                cpf: this.cpfA,
                login: this.loginA,
                senha: this.senhaA,
                telefone: this.telefoneA,
                email: this.emailA
            }).then(resp => console.log(resp.data)).catch(error => {console.log(error.response)});
            this.$router.push("/dashboard")
        }
    }
}
</script>

<style>

</style>