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
          <h4>Tabela de Pedidos</h4>
            <table border="1" id="table">
                <thead>
                    <tr>
                        <th>Número</th>
                        <th>Produto</th>
                        <th>Quantidade</th>
                        <th>Cliente</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="pedida in pedidos" :key="pedida.id">
                        <td>{{pedida.id}}</td>
                        <td>{{pedida.nomeProduto}}</td>
                        <td>{{pedida.quantidade}}</td>
                        <td>{{pedida.nomeCliente}}</td>
                    </tr>
                </tbody>
            </table>
      </div>
      <div>
          <h4>Tabela de Clientes</h4>
            <table border="1" id="table">
                <thead>
                    <tr>
                        <th>Nome</th>
                        <th>CPF</th>
                        <th>Telefone</th>
                        <th>Rua</th>
                        <th>Número</th>
                        <th>Complemento</th>
                        <th>Bairro</th>
                        <th>Cidade</th>
                    </tr>
                </thead>
                <tbody>
                    <tr v-for="clienta in clientes" :key="clienta.id">
                        <td>{{clienta.nome}}</td>
                        <td>{{clienta.cpf}}</td>
                        <td>{{clienta.telefone}}</td>
                        <td>{{clienta.rua}}</td>
                        <td>{{clienta.numero}}</td>
                        <td>{{clienta.complemento}}</td>
                        <td>{{clienta.bairro}}</td>
                        <td>{{clienta.cidade}}</td>
                    </tr>
                </tbody>
            </table>
      </div>
      <div>
          <button @click="irDados">Ver meus dados</button>
      </div>
    </div>
</template>

<script>
const axios = require('axios')

export default {
    data: function(){
        return {
            pedidos: [],
            clientes: [],
            loginF: this.$store.state.funcSel,
            loginA: this.$store.state.admSel
        }
    
    },methods: {
        irDados: function(){
            if(this.loginF != null){
                this.$router.push("/dadosFunc")
            }
            else if(this.loginA != null){
                this.$router.push("/dadosAdm")
            }
        }
    }
    , mounted(){
        axios.get("http://localhost:65343/api/Pedido").then(pe => this.pedidos = pe.data)
        axios.get("http://localhost:65343/api/Cliente").then(cli => this.clientes = cli.data)
    }
}
</script>

<style>

</style>