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
        <input type="text" v-model="nomeF" ><br>
        <span>CPF:</span>
        <input type="text" v-model="cpfF"><br>
        <span>Login:</span>
        <input type="text" v-model="loginF"><br>
        <span>Senha:</span>
        <input type="text" v-model="senhaF"><br>
        <span>Telefone:</span>
        <input type="text" v-model="telefoneF"><br>
        <span>E-mail:</span>
        <input type="text" v-model="emailF"><br>
        <span>Salário:</span>
        <input type="text" v-model="salarioF"><br>
        <button @click="alterar">Alterar</button>
      </div>
  </div>
  
</template>

<script>
const axios = require('axios')

export default {
    data: function(){
        return {
            funciSel: this.$store.state.funcSel,
            nomeF: this.$store.state.funcSel.nome,
            cpfF: this.$store.state.funcSel.cpf,
            loginF: this.$store.state.funcSel.login,
            senhaF: this.$store.state.funcSel.senha,
            telefoneF: this.$store.state.funcSel.telefone,
            emailF: this.$store.state.funcSel.email,
            salarioF: this.$store.state.funcSel.salario
        }
    }, methods: {
        alterar: function(){

            axios.put("http://localhost:65343/api/Funcionario/"+this.funciSel.id, {
                nome: this.nomeF,
                cpf: this.cpfF,
                login: this.loginF,
                senha: this.senhaF,
                telefone: this.telefoneF,
                email: this.emailF,
                salario: this.salarioF
            }).then(resp => console.log(resp.data)).catch(error => {console.log(error.response)});
            this.$router.push("/dashboard")
        }
    }
}
</script>

<style>

</style>