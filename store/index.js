export const state = () => ({
    showPlayPopup: false,
    showRankingPopup: false,
    showRulesPopup: false,
    userToken: null,
    isAuth: null,
})

export const mutations = {
    SET_SHOW_PLAY_POPUP(state, payload) {
        state.showPlayPopup = payload
    },
    SET_SHOW_RANKING_POPUP(state, payload) {
        state.showRankingPopup = payload
    },
    SET_SHOW_RULES_POPUP(state, payload) {
        state.showRulesPopup = payload
    },
    SET_USER_TOKEN(state, payload) {
        state.userToken = payload
    },
    SET_IS_AUTH(state, payload) {
        state.isAuth = payload
    },
}

export const actions = {
    isAuth({ commit, getters }) {
        this.$axios
            .$post(`/auth`, {
                token: getters.getUserToken,
            })
            .then((response) => {
                console.log(response)
                commit('SET_IS_AUTH', response)
            })
            .catch((response) => {
                console.log(response)
            })
    },

    showPlayPopup({ commit }) {
        commit('SET_SHOW_PLAY_POPUP', true)
    },
    closePlayPopup({ commit }) {
        commit('SET_SHOW_PLAY_POPUP', false)
    },

    showRankingPopup({ commit }) {
        commit('SET_SHOW_RANKING_POPUP', true)
    },
    closeRankingPopup({ commit }) {
        commit('SET_SHOW_RANKING_POPUP', false)
    },

    showRulesPopup({ commit }) {
        commit('SET_SHOW_RULES_POPUP', true)
    },
    closeRulesPopup({ commit }) {
        commit('SET_SHOW_RULES_POPUP', false)
    },

    setUserToken({ commit }, payload) {
        commit('SET_USER_TOKEN', payload)
        localStorage.setItem('CGAuthKey', JSON.stringify(payload))
    },
}

export const getters = {
    getUserToken: (state) => {
        if (state.userToken) return state.userToken
        const key = JSON.parse(localStorage.getItem('CGAuthKey'))
        if (key) return key
        else return null
    },
    getIsAuth: (state) => {
        return state.isAuth
    },
}
