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
          <h3>Delivery</h3>
          <h5>Pedido</h5>
          <span>Produto</span>
          <select v-model="produto" placeholder="Escolha">
            <option :value="produto.id" v-for="produto in produtos" :key="produto.id">
                {{produto.nome}}
            </option>
        </select><br>
        <span>Quantidade</span>
        <input type="number">
      </div>
  </div>
</template>

<script>
const axios = require('axios')

export default {
    data: function(){
        return {
            produto: 0,
            produtos: []
        }
    }, mounted(){
        axios.get("http://localhost:65343/api/Produto").then(pro => this.produtos = pro.data)
    }

}
</script>

<style>

</style>