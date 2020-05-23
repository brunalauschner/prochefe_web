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
      <input type="text" v-model="nome" ><br>
      <span>CPF:</span>
      <input type="text" v-model="cpf"><br>
      <span>Login:</span>
      <input type="text" v-model="login"><br>
      <span>Senha:</span>
      <input type="text" v-model="senha"><br>
      <span>Telefone:</span>
      <input type="text" v-model="telefone"><br>
      <span>Rua:</span>
      <input type="text" v-model="rua"><br>
      <span>Número:</span>
      <input type="text" v-model="numero"><br>
      <span>Complemento:</span>
      <input type="text" v-model="complemento"><br>
      <span>Bairro:</span>
      <input type="text" v-model="bairro"><br>
      <span>Cidade:</span>
      <input type="text" v-model="cidade"><br>
      <button @click="salvar">Salvar</button>
      </div>
    </div>
</template>

<script>
const axios = require('axios')

export default {
    data: function(){
        return {
            clientesCadastro: [],
            nome: '',
            cpf: '',
            login: '',
            senha: '',
            telefone: '',
            rua: '',
            numero: '',
            complemento: '',
            bairro: '',
            cidade: ''
        }
    }, methods: {
        salvar: function(){
            axios.post("http://localhost:65343/api/Cliente", {
                nome: this.nome,
                cpf: this.cpf,
                login: this.login,
                senha: this.senha,
                telefone: this.telefone,
                rua: this.rua,
                numero: this.numero,
                complemento: this.complemento,
                bairro: this.bairro,
                cidade: this.cidade
            }).then(resp => console.log(resp.data)).catch(error => {console.log(error.response)});
            this.$router.push("/entrar")
        }
    }, mounted(){
        axios.get("http://localhost:65343/api/Cliente").then(cli => this.clientesCadastro = cli.data)
    }
}
</script>

<style>

</style>