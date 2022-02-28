export const state = () => ({
    showPlayPopup: false,
    showRankingPopup: false,
    showRulesPopup: false,
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
}

export const actions = {
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
}

export const getters = {
    // getMainMenu: (state) => {
    //     return state.mainMenu
    // },
}
