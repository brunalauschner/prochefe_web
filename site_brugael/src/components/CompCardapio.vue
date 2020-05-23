<template>
  <div id="compcarGeral">
      <div class="links2">
      <router-link class="link" to="/">Home</router-link>
      <router-link class="link" to="/sobrenos">Sobre Nós</router-link>
      <router-link class="link" to="/cardapio">Cardápio</router-link>
      <router-link class="link" to="/delivery">Delivery</router-link>
      <router-link class="link" to="/sugestoes">Sugestões</router-link>
      <router-link class="link" to="/entrar">Clientes</router-link>
      <router-link class="link" to="/intranet">Intranet</router-link>
      </div>
     
      <div id="listas">
        <h3>Pães</h3> 
        <ul v-for="produto in produtos" :key="produto.id">
            <li v-if="produto.id_categoria == 1">{{produto.nome}}</li>
        </ul>
        <h3>Salgados</h3>
        <ul v-for="produto in produtos" :key="produto.id">
            <li v-if="produto.id_categoria == 2">{{produto.nome}}</li>
        </ul>
        <h3>Doces</h3>
        <ul v-for="produto in produtos" :key="produto.id">
            <li v-if="produto.id_categoria == 3">{{produto.nome}}</li>
        </ul>
        <h3>Bebidas</h3>
        <ul v-for="produto in produtos" :key="produto.id">
            <li v-if="produto.id_categoria == 4">{{produto.nome}}</li>
        </ul>
         
      </div>
    </div>
</template>

<script>
const axios = require('axios')

export default {
    data: function(){
        return {
            produtos: []
        }
    }, methods: {

    }, mounted(){
        axios.get("http://localhost:65343/api/Produto").then(prod1 => this.produtos = prod1.data)
    }
}
</script>

<style>
#listas{
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
}
</style>