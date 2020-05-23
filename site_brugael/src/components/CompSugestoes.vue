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
          <h2>Sugestões</h2>
          <span>Este é um espaço para nós ouvirmos suas sugestões, reclamações ou elogios. Por favor, seja respeitoso.</span>
          <h5>Nome</h5>
          <input type="text">
          <h5>E-mail</h5>
          <input type="text">
          <h5>Mensagem</h5>
          <input type="text">
          <button>Submeter</button>
          <span>Se desejar, sinta-se livre para nos contatar por outros meios:</span><br>
          <span>(47) 3854-6201</span><br>
          <span>padariabrugael@contato.com</span>
      </div>
  </div>
</template>

<script>
export default {

}
</script>

<style>

</style>