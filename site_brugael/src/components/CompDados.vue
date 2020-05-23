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
      <button @click="alterar">Alterar</button>
      <button @click="excluir">Excluir conta</button>
      </div>
    </div>
</template>

<script>
const axios = require('axios')

export default {
    data: function(){
        return {
            clientesDados: [],
            cliAlterado: [],
            cliExcluido: [],
            cliSel: this.$store.state.clienteSel,
            nomeA: this.$store.state.clienteSel.nome,
            cpf: this.$store.state.clienteSel.cpf,
            login: this.$store.state.clienteSel.login,
            senha: this.$store.state.clienteSel.senha,
            telefone: this.$store.state.clienteSel.telefone,
            rua: this.$store.state.clienteSel.rua,
            numero: this.$store.state.clienteSel.numero,
            complemento: this.$store.state.clienteSel.complemento,
            bairro: this.$store.state.clienteSel.bairro,
            cidade: this.$store.state.clienteSel.cidade
        }
    }, methods: {
        alterar: function(){

            axios.put("http://localhost:65343/api/Cliente/"+this.cliSel.id, {
                nome: this.nomeA,
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

        },
        excluir: function(){
            this.clientesDados.filter(clo => {
                if(clo.id == this.cliSel.id){
                    this.cliExcluido = clo
                }
            })
            axios.delete("http://localhost:65343/api/Cliente/"+this.cliExcluido.id).then(res => console.log(res.data)).catch(error => {console.log(error.response)});
        }
    }, mounted(){
        axios.get("http://localhost:65343/api/Cliente").then(cli => this.clientesDados = cli.data)
    }
}
</script>

<style>

</style>